using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows;

namespace CS_TimedReminders
{
    class TimerLogic
    {
        public DateTime DateAndTime { get; set; }

        /// <summary>
        /// Gets the current time.
        /// </summary>
        /// <returns>
        /// Returns a DateTime object.
        /// </returns>
        public DateTime GetCurrentTime()
        {
            try
            {
                return DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get current time.");
                throw;
            }
        }

        public void TimeOut()
        {
            // Play sound //
            SoundPlayer sound = new SoundPlayer(Properties.Resources.DefaultSound);
            sound.Play();


        }
    }
}
