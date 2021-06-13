/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Exceptions;
using System;
using System.Media;

namespace Models {
    public static class MyPlayer {

        #region Attributes

        static SoundPlayer player;
        static private bool isPlaying;
        static private bool isLooping;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with default constructor.
        /// </summary>
        static MyPlayer() {
            player = new SoundPlayer();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The location of the sound.
        /// </summary>
        public static string SoundLocation {
            get => player.SoundLocation;
            set {
                if (value.GetType() == typeof(string)) {
                    player.SoundLocation = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the boolean state of it's playing or not.
        /// </summary>
        public static bool IsPlaying {
            get => isPlaying;
            set {
                if (value.GetType() == typeof(bool)) {
                    isPlaying = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the boolean state of it's Looping or not.
        /// </summary>
        public static bool IsLooping {
            get => isLooping;
            set {
                if (value.GetType() == typeof(bool)) {
                    isLooping = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Plays the sound passed by parameter.
        /// </summary>
        public static void Play(string soundName, bool playInLoop) {
            SoundLocation = $"{Environment.CurrentDirectory}\\Sounds\\{soundName}.wav";
            try {
                if (playInLoop) {
                    IsLooping = true;
                    player.PlayLooping();
                } else {
                    IsLooping = false;
                    player.Play();
                }
                IsPlaying = true;
            } catch (Exception e) {
                throw new NoSoundFoundException($"The '{soundName}.wav' is missing in the Sound's Directory.", e);
            }
        }

        /// <summary>
        /// If the SoundPlayer instance isPlaying, stops it.
        /// </summary>
        public static void Stop() {
            if (IsPlaying) {
                IsPlaying = false;
                IsLooping = false;
                player.Stop();
            }
        }

        #endregion
    }
}
