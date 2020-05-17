using NUnit.Framework;
namespace QuantityMeasurmentTest
{
    public class Tests
    {
        ConvertUnit convertu= new ConvertUnit();
        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Feet, 0.0);
            length feet2 = new length(length.Unit.Feet, 0.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.2 Given 0 Feet And 1 Feet Should Return not Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndOneFeet_WhenCalculated_ShouldReturnNotEqual()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Feet, 0.0);
            length feet2 = new length(length.Unit.Feet, 1.0);

            //Asserting Values.
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.3 Given 0 inch And 0 inch Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Inch, 0.0);
            length feet2 = new length(length.Unit.Inch, 0.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.4 Given 0 inch And 1 inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndOneInch_WhenCalculated_ShouldReturnNotEqual()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Inch, 0.0);
            length feet2 = new length(length.Unit.Inch, 1.0);

            //Asserting Values.
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.5 Given 0 inch And 0 feet Should Return  Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndzeroFeet_WhenCalculated_ShouldReturnEqualLenth()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Inch, 0.0);
            length feet2 = new length(length.Unit.Feet, 0.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }
        /// <summary>
        /// Test Case 1.6 Given 1 inch And 1 feet Should Return Not Equal.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneFeet_WhenCalculated_ShouldReturnNotEqualLenth()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Inch, 1.0);
            length feet2 = new length(length.Unit.Feet, 1.0);

            //Asserting Values.
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.7 Given 1 feet And 1 feet Should Return  Equal.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenCalculated_ShouldReturnEqualLenth()
        {
            //Creating Feet Instance.
            length feet1 = new length(length.Unit.Feet, 1.0);
            length feet2 = new length(length.Unit.Feet, 1.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }


        /// <summary>
        /// Test Case 1.8 Given Null Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullFeetValues_WhenCalculated_ShouldReturnEqual()
        {
            try
            {
                length aa = new length();
                //Asserting Values.
                Assert.AreEqual(aa.Equals(null), QuantityMeasurementException.ExceptionType.Null_Exception);
            }
            catch (Exception e)
            {
                _ = e.StackTrace;

            }
        }



        /// <summary>
        /// Test Case 1.9 Given References Having Same Object Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameReferences_WhenCalculated_ShouldReturnEqual()
        {
            //Creeating Feet Instance.
            length feet1 = new length(length.Unit.Feet, 0.0);
            length feet2 = feet1;

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.10 Given Feet Type Data Should Return Equal.
        /// </summary>
        [Test]
        public void GivenFeet1andFeet2Types_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Instances.
            length feet1 = new length(length.Unit.Feet, 0.0);
            length feet2 = new length(length.Unit.Feet, 0.0);

            Type typeFeet1 = feet1.GetType();
            Type typeFeet2 = feet2.GetType();

            //Asserting Values.
            Assert.AreEqual(typeFeet1, typeFeet2);
        }


        /// <summary>
        /// Test Case 1.11 Given Null Inch Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullInchValues_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Inch Instances.
            length inch1 = null;
            length inch2 = null;

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.12 Given Two References Of Same Type Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameInchReferences_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Inch Instances.
            length inch1 = new length(length.Unit.Inch, 0.0);
            length inch2 = inch1;

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.13 Given Same Type References Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInchTypeReference_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Inch Instances.
            length inch1 = new length(length.Unit.Inch, 0.0);
            length inch2 = new length(length.Unit.Inch, 0.0);

            //Getting Type Of Reference.
            Type typeInch1 = inch1.GetType();
            Type typeInch2 = inch2.GetType();

            //Asserting Values.
            Assert.AreEqual(typeInch1, typeInch2);
        }



        /// <summary>
        /// Test Case 1.14 Given 1 Feet And 1 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCalculated_ShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            length feet = new length(length.Unit.Feet, 1);
            length inch = new length(length.Unit.Inch, 1);

            //Asserting Values.
            Assert.AreNotEqual(feet, inch);
            Assert.AreNotEqual(inch, feet);

        }

        /// <summary>
        /// Test Case 1.15 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            length feet = new length(length.Unit.Feet, 1);
            length inch = new length(length.Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Test Case 1.16 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            length feet = new length(length.Unit.Feet, 1);
            length inch = new length(length.Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(inch, feet);
        }

        /// <summary>
        /// Test Case 2.17 Given 3 Feet And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            length feet = new length(length.Unit.Feet, 3);
            length yard = new length(length.Unit.Yard, 1);

            //Asserting Values.
            Assert.AreEqual(feet, yard);
        }

        /// <summary>
        /// Test Case 2.18 Given 1 Feet And 1 Yard Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenCalculated_ShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            length feet = new length(length.Unit.Feet, 1);
            length yard = new length(length.Unit.Yard, 1);

            //Asserting Values.
            Assert.AreNotEqual(feet, yard);
        }

        /// <summary>
        /// Test Case 2.19 Given 1 Yard And 36 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenCalculated_ShouldReturEqual()
        {
            //Creating Length Instances For Feet and Inch
            length yard = new length(length.Unit.Yard, 1);
            length inch = new length(length.Unit.Inch, 36);

            //Asserting Values.
            Assert.AreEqual(yard, inch);
        }

        /// <summary>
        /// Test Case 2.20 Given 36 Inch And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given36InchAnD1Yard_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            length yard = new length(length.Unit.Yard, 1);
            length inch = new length(length.Unit.Inch, 36);

            //Asserting Values.
            Assert.AreEqual(inch, yard);
        }

        /// <summary>
        /// Test Case 2.21 Given 1 Yard And 3 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd3Feet_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            length yard = new length(length.Unit.Yard, 1);
            length feet = new length(length.Unit.Feet, 3);

            //Asserting Values.
            Assert.AreEqual(yard, feet);
        }

        /// <summary>
        /// Test Case 3.22 Given 2 Inch And 5 Centimeter Should Return Equal.
        /// </summary>
        [Test]
        public void Given2InchAnd5Centimeter_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Length Instances For Inch And Centimeter.
            length inch = new length(length.Unit.Inch, 2);
            length centimeter = new length(length.Unit.Centimeter, 5);

            //Asserting Values.
            Assert.AreEqual(inch, centimeter);
        }

        /// <summary>
        /// Test Case 4.23 Given 2 Inch And 2 Inch Should Return 4 Inch.
        /// </summary>
        [Test]
        public void Gievn2InchAnd2Inch_WhenCalculated_ShouldReturn4Inch()
        {
            //Creating Inch Instances.
            length inch1 = new length(Unit.Inch, 2);
            length inch2 = new length(Unit.Inch, 2);
            double result = convertu.AddLengths(inch1, inch2);
            double expected = 4;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.24 Given 1 Feet And 2 Inch Should Return 14 Inches.
        /// </summary>
        [Test]
        public void Given1FeetAnd2Inch_WhenCalculated_ShouldReturn14Inch()
        {
            //Creating Feet And Inch Instances.
            length inch = new length(Unit.Inch, 2);
            length feet = new length(Unit.Feet, 1);
            double result = convertu.AddLengths(feet, inch);
            double expected = 14;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.25 Given 1 Feet And 1 Feet Should Return 24 Inches.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCalculated_ShouldReturn24Inch()
        {
            length feet = new length(Unit.Feet, 1);
            length feet1 = new length(Unit.Feet, 1);
            double result = convertu.AddLengths(feet, feet1);
            double expected = 24;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.26 Given 2 Inch Adn 2.5 Centimeter Should Return 3 Inch. 
        /// </summary>
        [Test]
        public void Given2InchAnd2point5Centimeter_WhenCalculated_ShouldReturn3Inch()
        {
            //Creating Length Instances and Performing Operation.
            length inch = new length(Unit.Inch, 2);
            length centimeter = new length(Unit.Centimeter, 2.5);

            double result = convertu.AddLengths(inch, centimeter);
            double expected = 3;

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 5.27 Given 1 Gallon And 3.78 Litre Should Return Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd3point78Litre_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Volume Instances For Gallon And Litre.
            Volume gallon = new Volume(Unit.Gallon, 1.0);
            Volume litre = new Volume(Unit.Litre, 3.78);

            //Asserting Values.
            Assert.AreEqual(gallon, litre);
        }

        /// <summary>
        /// Test Case 5.28 Given 1 Litre And 1000 MiliLitre Should Return Equal.
        /// </summary>
        [Test]
        public void Given1LitreAnd1000MiliLitre_WhenCalculated_ShouldReturnEqual()
        {
            //Creating Volume Instances For Litre And Mililitre.
            Volume litre = new Volume(Unit.Litre, 1);
            Volume miliLitre = new Volume(Unit.Mililitre, 1000);

            //Asserting Values.
            Assert.AreEqual(litre, miliLitre);
        }

        /// <summary>
        /// Test Case 6.29 Given 1 Gallon And 3.785 Litre Should Return 7.57.
        /// </summary>
        [Test]
        public void Given1GallonAnd3point785Litre_WhenCalculated_ShouldReturn7point57Litre()
        {
            //Creating Volume Instances.
            Volume gallon = new Volume(Unit.Gallon, 1);
            Volume litre = new Volume(Unit.Litre, 3.785);

            double expected = 7.57;
            double result = convertu.AddVolumes(gallon, litre);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 6.30 Given 1 Litre And 1000 Mililitre Should Return 2 Litre.
        /// </summary>
        [Test]
        public void Given1LitreAnd1000Mililitre_WhenCalculated_ShouldReturn2Litre()
        {
            //Creating Instances For Volumes.
            Volume litre = new Volume(Unit.Litre, 1);
            Volume miliLitre = new Volume(Unit.Mililitre, 1000);

            double expected = 2;
            double result = convertu.AddVolumes(litre, miliLitre);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Test Case 7.31 Given 1 Kilogram And 1000 Gram Should Return Equal.
        /// </summary>
        [Test]
        public void Given1KiloGramsAnd1000GramsShouldReturnEqul()
        {
            //Creating Instances Of Weights.
            Weight kiloGrams = new Weight(Unit.KiloGram, 1.0);
            Weight grams = new Weight(Unit.Grams, 1000);

            //Assertin Values.
            Assert.AreEqual(kiloGrams, grams);
        }

        /// <summary>
        /// Test Case 7.32 Given 1 Tonne And 1000  kilograms Should Return Equal.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000KilogramsShouldReturnEqual()
        {
            //Creating Weight Instances For Tonne And Kilogram.
            Weight tonne = new Weight(Unit.Tonne, 1);
            Weight kilograms = new Weight(Unit.KiloGram, 1000);

            //Asserting Value.
            Assert.AreEqual(tonne, kilograms);
        }

        /// <summary>
        /// Test Case 7.33 Given 1 Tonne And 1000 Grams Should Return 1001 Kilograms.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000GramShouldReturn1001Kilogram()
        {
            //Creating Weight Instances For Tonne And Grams.
            Weight tonne = new Weight(Unit.Tonne, 1);
            Weight grams = new Weight(Unit.Grams, 1000);

            double expected = 1001;
            double result = convertu.AddWeights(tonne, grams);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }
    }
}