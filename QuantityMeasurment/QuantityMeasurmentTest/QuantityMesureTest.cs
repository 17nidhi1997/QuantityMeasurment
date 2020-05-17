using NUnit.Framework;
namespace QuantityMeasurmentTest
{
    public class Tests
    {
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
    }
}