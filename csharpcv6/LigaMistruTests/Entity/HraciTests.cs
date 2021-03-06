﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LigaMistru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaMistru.Tests
{
    [TestClass()]
    public class HraciTests
    {
        [TestMethod()]
        public void InicializovanyObjektJePrazdny()
        {
            Hraci hraci = new Hraci();

            // nic nedelej

            Assert.AreEqual(0, hraci.Pocet);
        }

        [TestMethod()]
        public void PridejBezRealokacePole()
        {
            Hraci hraci = new Hraci();
            HracForm hrac = new HracForm();

            hraci.Pridej(hrac);

            Assert.AreEqual(1, hraci.Pocet);
            Assert.AreSame(hrac, hraci[0]);
        }

        [TestMethod()]
        public void PridejSRealokaciPole()
        {
            Hraci hraci = new Hraci();
            HracForm hrac1 = new HracForm();
            HracForm hrac2 = new HracForm();
            HracForm hrac3 = new HracForm();
            HracForm hrac4 = new HracForm();
            HracForm hrac5 = new HracForm();

            hraci.Pridej(hrac1);
            hraci.Pridej(hrac2);
            hraci.Pridej(hrac3);
            hraci.Pridej(hrac4);
            hraci.Pridej(hrac5);

            Assert.AreEqual(5, hraci.Pocet);
            Assert.AreSame(hrac1, hraci[0]);
            Assert.AreSame(hrac2, hraci[1]);
            Assert.AreSame(hrac3, hraci[2]);
            Assert.AreSame(hrac4, hraci[3]);
            Assert.AreSame(hrac5, hraci[4]);
        }

        [TestMethod()]
        public void VymazHrace()
        {
            Hraci hraci = new Hraci();
            HracForm hrac = new HracForm();
            hraci.Pridej(hrac);

            hraci.Vymaz(0);

            Assert.AreEqual(0, hraci.Pocet);
        }

        [TestMethod()]
        public void VymazHraceUprostredPole()
        {
            Hraci hraci = new Hraci();
            HracForm hrac1 = new HracForm();
            HracForm hrac2 = new HracForm();
            HracForm hrac3 = new HracForm();
            HracForm hrac4 = new HracForm();
            HracForm hrac5 = new HracForm();
            hraci.Pridej(hrac1);
            hraci.Pridej(hrac2);
            hraci.Pridej(hrac3);
            hraci.Pridej(hrac4);
            hraci.Pridej(hrac5);

            hraci.Vymaz(2); // hrac3

            Assert.AreEqual(4, hraci.Pocet);
            Assert.AreSame(hrac1, hraci[0]);
            Assert.AreSame(hrac2, hraci[1]);
            Assert.AreSame(hrac4, hraci[2]);
            Assert.AreSame(hrac5, hraci[3]);
        }

        [TestMethod()]
        public void NajdiNejlepsiKlub()
        {
            Hraci hraci = new Hraci();
            HracForm hrac1 = new HracForm()
            {
                Klub = FotbalovyKlub.Arsenal,
                GolPocet = 10
            };
            HracForm hrac2 = new HracForm()
            {
                Klub = FotbalovyKlub.FCPorto,
                GolPocet = 15
            };
            HracForm hrac3 = new HracForm()
            {
                Klub = FotbalovyKlub.Arsenal,
                GolPocet = 10
            };
            hraci.Pridej(hrac1);
            hraci.Pridej(hrac2);
            hraci.Pridej(hrac3);

            hraci.NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int golPocet);

            Assert.AreEqual(20, golPocet);
            Assert.AreEqual(1, kluby.Length);
            Assert.AreEqual(FotbalovyKlub.Arsenal, kluby[0]);
        }

        [TestMethod()]
        public void NajdiNejlepsiKluby()
        {
            Hraci hraci = new Hraci();
            HracForm hrac1 = new HracForm()
            {
                Klub = FotbalovyKlub.Arsenal,
                GolPocet = 10
            };
            HracForm hrac2 = new HracForm()
            {
                Klub = FotbalovyKlub.FCPorto,
                GolPocet = 15
            };
            HracForm hrac3 = new HracForm()
            {
                Klub = FotbalovyKlub.Arsenal,
                GolPocet = 10
            };
            HracForm hrac4 = new HracForm()
            {
                Klub = FotbalovyKlub.FCPorto,
                GolPocet = 5
            };
            HracForm hrac5 = new HracForm()
            {
                Klub = FotbalovyKlub.Barcelona,
                GolPocet = 19
            };
            hraci.Pridej(hrac1);
            hraci.Pridej(hrac2);
            hraci.Pridej(hrac3);
            hraci.Pridej(hrac4);
            hraci.Pridej(hrac5);

            hraci.NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int golPocet);

            Assert.AreEqual(20, golPocet);
            Assert.AreEqual(2, kluby.Length);
            Assert.AreEqual(FotbalovyKlub.FCPorto, kluby[0]);
            Assert.AreEqual(FotbalovyKlub.Arsenal, kluby[1]);
        }
    }
}