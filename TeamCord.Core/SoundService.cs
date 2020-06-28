﻿using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace TeamCord.Core
{
    public class SoundService : IDisposable
    {
        private BufferedWaveProvider _waveProvider;
        private VolumeSampleProvider _volumeSampleProvider;
        private WaveOut _waveOut;
        public ulong UserID { get; private set; }

        /// <summary>
        /// Audio volume of user, 1.0 is full
        /// </summary>
        public float Volume
        {
            get
            {
                return _volumeSampleProvider.Volume;
            }
            set
            {
                _volumeSampleProvider.Volume = value;
            }
        }

        /// <summary>
        /// Master audio volume, 1.0 is full
        /// </summary>
        public float MasterVolume
        {
            get
            {
                return _waveOut.Volume;
            }
            set
            {
                _waveOut.Volume = value;
            }
        }

        public SoundService(ulong userID)
        {
            UserID = userID;
            InitSpeakers();
        }

        public void StartPlayback()
        {
            _waveOut.Play();
            Logging.Log($"Playback started of userID {UserID}");
        }

        public void StopPlayback()
        {
            _waveOut.Stop();
            Logging.Log($"Playback stopped of userID {UserID}");
        }

        private void InitSpeakers()
        {
            _waveProvider = new BufferedWaveProvider(new WaveFormat(48000, 2))
            {
                DiscardOnBufferOverflow = true
            };
            _waveOut = new WaveOut
            {
                DesiredLatency = 700,
                NumberOfBuffers = 3
            };
            _waveOut.PlaybackStopped += _waveOut_PlaybackStopped;
            _volumeSampleProvider = new VolumeSampleProvider(_waveProvider.ToSampleProvider());
            _waveOut.Init(_volumeSampleProvider);
        }

        private void _waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception == null)
                Logging.Log($"Sound playback stoppped of ID: {UserID}");
            else
                Logging.Log(e.Exception);
        }

        public void AddSamples(byte[] buffer)
        {
            _waveProvider.AddSamples(buffer, 0, buffer.Length);
        }

        public void Dispose()
        {
            _waveOut.Dispose();
            _waveProvider = null;
            Logging.Log($"Disposed SoundService of userID: {UserID}");
        }
    }
}