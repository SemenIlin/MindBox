using System;

namespace CalculateSquare
{
    public static class Calculate
    {
        #region Circle
        public static double GetSquareCircle(double radius)
        {
            if(radius <= 0)
            {
                throw new Exception("Radius should be more than 0.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }
        #endregion

        #region Triangle
        public static double GetSquareTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsExistTriangle(firstSide,secondSide, thirdSide))
            {
                throw new Exception("This triangle is not exist.");
            }
            var halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            return Math.Pow(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide), 0.5);
        }

        public static bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
        {
            var shotSides = GetShotSides(firstSide, secondSide, thirdSide);

            return Math.Pow(GetLongSide(firstSide, secondSide, thirdSide), 2) ==
                Math.Pow(shotSides.sideOne, 2) + Math.Pow(shotSides.sideTwo, 2);            
        }

        public static bool IsExistTriangle(double firstSide, double secondSide, double thirdSide)
        {
            var shotSides = GetShotSides(firstSide, secondSide, thirdSide);
            return GetLongSide(firstSide, secondSide, thirdSide) < shotSides.sideOne + shotSides.sideTwo;
        }

        private static double GetLongSide(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide >= secondSide && firstSide >= thirdSide)
            {
                return firstSide;
            }
            else if(secondSide >= firstSide && secondSide >= thirdSide)
            {
                return secondSide;
            }
            else
            {
                return thirdSide;
            }

        }

        private static double GetLongSide(double firstSide, double secondSide)
        {
            return firstSide >= secondSide ? firstSide : secondSide;
        }

        private static (double sideOne, double sideTwo) GetShotSides(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide >= secondSide && firstSide >= thirdSide)
            {
                return (sideOne: secondSide, sideTwo :thirdSide);
            }
            else if (secondSide >= firstSide && secondSide >= thirdSide)
            {
                return (sideOne: firstSide, sideTwo: thirdSide);
            }
            else
            {
                return (sideOne: secondSide, sideTwo: firstSide);
            }

        }
        #endregion
    }
}
