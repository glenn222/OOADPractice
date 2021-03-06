﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOADExercise.Exercise_3__DougsDogDoor
{
    public class DogDoor
    {
        private bool open;
        private int openTime;
        private List<Bark> allowedBarks;

        public DogDoor()
        {
            this.open = false;
            this.openTime = 5000;
            this.allowedBarks = new List<Bark>();
        }

        public DogDoor(int openTime)
        {
            this.open = false;
            this.openTime = openTime;
            this.allowedBarks = new List<Bark>();
        }

        public void Open()
        {
            Console.WriteLine("The dog door is open.");
            open = true;

            Timer timer = new Timer(openTime);
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Start();
        }

        public void Close()
        {
            Console.WriteLine("The dog door is closed.");
            open = false;
        }

        public void setOpenTime(int openTime)
        {
            this.openTime = openTime;
        }

        //Returns the state of the door, whether open or closed
        public Boolean isOpen()
        {
            return open;
        }

        public void addAllowedBark (Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> getAllowedBarks()
        {
            return allowedBarks;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            autoCloseDoor((Timer)sender);
        }

        private void autoCloseDoor(Timer timer)
        {
            Close();
            timer.Stop();
        }

    }
}
