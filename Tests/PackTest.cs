using System;
using System.Collections.Generic;
using Implementations;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PackTest
    {
        List<IDimension> dimensions = new List<IDimension>();
        IAddress destination = new Address("Bart Simpson", "V3M 1T4", "Canada", "BC", "Vancouver");
        IAddress source = new Address("Lisa Simpson", "ABC 123", "Canada", "BC", "Richmond");

        [TestMethod]
        public void GetTotal_From_API1()
        {
            Pack packing = new Pack();
            packing.destination = destination;
            packing.source = source;
            packing.dimensions = dimensions;

            decimal total = Services.API1.Services.API1Service.getTotal(packing);

            Assert.AreEqual(total, 10m);

        }


        [TestMethod]
        public void GetTotal_From_API2()
        {
            Pack packing = new Pack();
            packing.destination = destination;
            packing.source = source;
            packing.dimensions = dimensions;

            decimal amout = Services.API2.Services.API2Service.getAmout(packing);

            Assert.AreEqual(amout, 6.56m);
        }

        [TestMethod]
        public void GetTotal_From_API3()
        {
            Pack packing = new Pack();
            packing.destination = destination;
            packing.source = source;
            packing.dimensions = dimensions;

            decimal quote = Services.API3.Services.API3Service.getQuote(packing);

            Assert.AreEqual(quote, 13.34m);
        }

        [TestMethod]
        public void getTheLowestOffer_From_AllAPIs()
        {
            Pack packing = new Pack();
            packing.destination = destination;
            packing.source = source;
            packing.dimensions = dimensions;

            decimal lowest = Services.PackService.getTheLowestOffer(packing);

            Assert.AreEqual(lowest, 6.56m);

        }

    }
}
