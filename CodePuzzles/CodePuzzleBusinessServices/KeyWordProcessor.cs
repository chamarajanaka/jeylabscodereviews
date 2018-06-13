using CodePuzzleBusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePuzzleBusinessServices
{
    /// <summary>
    /// User input processing class
    /// </summary>
    public class KeyWordProcessor : IKeyWordProcessor
    {
        /// <summary>
        /// Remove the generic words from the input and keep the important key words
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public string StripUserInput(string userInput)
        {
            userInput = userInput.ToLower();
            string strippedString = userInput.Replace(StripWords.And_a, "").Replace(StripWords.Draw_an, "").Replace(StripWords.Draw_a, "").Replace(StripWords.Of, "")
                  .Replace(StripWords.With_a, "");

            return strippedString;
        }

        /// <summary>
        /// Identitify the shape from stripped string
        /// </summary>
        /// <param name="strippedString">Stripped string</param>
        /// <returns></returns>
        public Shape IdentifyShape(string strippedString)
        {
            Shape shape = new Shape();

            //Identify square shape
            if (strippedString.Contains(SupportedShapes.Square))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.Square, "").Replace(MeasurementStrip.SideLength, "").Trim();
                shape = new Square()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.Square.ToString()
                };
                
            }

            //Identify pentagon shape
            if (strippedString.Contains(SupportedShapes.Pentagon))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.Pentagon, "").Replace(MeasurementStrip.SideLength, "").Trim();
                shape = new Pentagon()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.Pentagon.ToString()
                };

            }

            //Identify rectangle shape
            if (strippedString.Contains(SupportedShapes.Rectangle))
            {
                int height = 0;
                int width = 0;

                string[] values = strippedString.Replace(SupportedShapes.Rectangle, "").Split(' ');

                GetWidth_Height(values, out width, out height);

                shape = new Rectangle()
                {
                    Height = height,
                    Width = width,
                    ShapeName = SupportedEnumShapes.Rectangle.ToString()
                };

            }

            //Identify octagon shape
            if (strippedString.Contains(SupportedShapes.Octagon))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.Octagon, "").Replace(MeasurementStrip.SideLength, "").Trim();
                shape = new Octagon()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.Octagon.ToString()
                };

            }

            //Identify circle shape
            if (strippedString.Contains(SupportedShapes.Circle))
            {
                string radius = strippedString.Replace(SupportedShapes.Circle, "").Replace(MeasurementStrip.Radius, "").Trim();
                shape = new Circle()
                {
                    Radius = Convert.ToInt32(radius),
                    ShapeName = SupportedEnumShapes.Circle.ToString()
                };

            }

            //Identify Hexagon shape
            if (strippedString.Contains(SupportedShapes.Hexagon))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.Hexagon, "").Replace(MeasurementStrip.SideLength, "").Trim();
                shape = new Hexagon()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.Hexagon.ToString()
                };

            }

            //Identify Heptagon shape
            if (strippedString.Contains(SupportedShapes.Heptagon))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.Heptagon, "").Replace(MeasurementStrip.SideLength, "").Trim();
                shape = new Heptagon()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.Heptagon.ToString()
                };

            }

            //Identify Equilateral Triangle
            if (strippedString.Contains(SupportedShapes.EquilateralTriangle))
            {
                string sideLenght = strippedString.Replace(SupportedShapes.EquilateralTriangle, "").Replace(MeasurementStrip.SideLength, "").Trim();

                shape = new EquilateralTriangle()
                {
                    SideLength = Convert.ToInt32(sideLenght),
                    ShapeName = SupportedEnumShapes.EquilateralTriangle.ToString()
                };

            }

            //Identify Isosceles Triangle
            if (strippedString.Contains(SupportedShapes.IsoscelesTriangle))
            {
                int height = 0;
                int width = 0;

                string[] values = strippedString.Replace(SupportedShapes.IsoscelesTriangle, "").Split(' ');

                GetWidth_Height(values, out width, out height);

                shape = new Rectangle()
                {
                    Height = height,
                    Width = width,
                    ShapeName = SupportedEnumShapes.IsoscelesTriangle.ToString()
                };

            }

            //Identify oval shape
            if (strippedString.Contains(SupportedShapes.Oval))
            {
                string radius = strippedString.Replace(SupportedShapes.Oval, "").Replace(MeasurementStrip.Radius, "").Trim();
                shape = new Oval()
                {
                    Radius = Convert.ToInt32(radius),
                    ShapeName = SupportedEnumShapes.Oval.ToString()
                };

            }          

            return shape;
        }

        /// <summary>
        /// Generic method to get width & height from stripped string
        /// </summary>
        /// <param name="values">string array</param>
        /// <param name="_width">out width</param>
        /// <param name="_height">out height</param>
        private void GetWidth_Height(string[] values, out int _width, out int _height)
        {
            int height = 0;
            int width = 0;

            values = values.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (values[0] == MeasurementStrip.Height)
            {
                height = Convert.ToInt32(values[1]);
            }
            else if (values[0] == MeasurementStrip.Width)
            {
                width = Convert.ToInt32(values[1]);
            }

            if (values[2] == MeasurementStrip.Height)
            {
                height = Convert.ToInt32(values[3]);
            }
            else if (values[2] == MeasurementStrip.Width)
            {
                width = Convert.ToInt32(values[3]);
            }

            _width = width;
            _height = height;
        }
    }

    
}
