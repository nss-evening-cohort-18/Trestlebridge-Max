﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Ostrich : IResource, IFeeding, IMeatProducing, IEgg
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 2.6;
        private int _eggProduced = 3;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Ostrich";
        public double FeedPerDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Methods

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Ostrich {this._shortId}. SQUAK!";
        }

        public void Feed()
        {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

        public double GetEggs()
        {
            return _eggProduced;
        }
    }
}
