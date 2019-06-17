using System;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            if (width == 0 || height == 0)
            {
                return new char[0, 0];
            }

            uint widthDiagram = width + 4;
            uint heightDiagram = height + 4;

            char[,] diagram2D = new char[heightDiagram, widthDiagram];

            for (int i = 0; i < widthDiagram; ++i)
            {
                diagram2D[0, i] = '-';
            }

            diagram2D[1, 0] = '|';
            
            for (int i = 1; i < widthDiagram - 1; ++i)
            {
                diagram2D[1, i] = ' ';
            }

            diagram2D[1, widthDiagram - 1] = '|';

            for (int i = 0; i < height; ++i)
            {
                diagram2D[i + 2, 0] = '|';
                diagram2D[i + 2, 1] = ' ';

                diagram2D[i + 2, widthDiagram - 2] = ' ';
                diagram2D[i + 2, widthDiagram - 1] = '|';
            }

            diagram2D[heightDiagram - 2, 0] = '|';

            for (int i = 1; i < widthDiagram - 1; ++i)
            {
                diagram2D[heightDiagram - 2, i] = ' ';
            }

            diagram2D[heightDiagram - 2, widthDiagram - 1] = '|';

            for (int i = 0; i < widthDiagram; ++i)
            {
                diagram2D[heightDiagram - 1, i] = '-';
            }

            switch (shape)
            {
                case EShape.Rectangle:
                    for (int i = 0; i < height; ++i)
                    {
                        for (int j = 0; j < width; ++j)
                        {
                            diagram2D[i + 2, j + 2] = '*';
                        }
                    }
                    break;

                case EShape.IsoscelesRightTriangle:
                    if (width != height)
                    {
                        return new char[0, 0];
                    }

                    for (int i = 0; i < height; ++i)
                    {
                        for (int j = 0; j < width; ++j)
                        {
                            if (i >= j)
                            {
                                diagram2D[i + 2, j + 2] = '*';
                            }
                            else
                            {
                                diagram2D[i + 2, j + 2] = ' ';
                            }
                        }
                    }
                    break;

                case EShape.IsoscelesTriangle:
                    if (width != height * 2 - 1)
                    {
                        return new char[0, 0];
                    }

                    for (int i = 0; i < height; ++i)
                    {
                        int numStars = 2 * i + 1;
                        int emptySpaceEachSide = ((int)width - numStars) / 2;
                        for (int j = 0; j < emptySpaceEachSide; ++j)
                        {
                            diagram2D[i + 2, j + 2] = ' ';
                        }
                        for (int j = 0; j < numStars; ++j)
                        {
                            diagram2D[i + 2, j + 2 + emptySpaceEachSide] = '*';
                        }
                        for (int j = 0; j < emptySpaceEachSide; ++j)
                        {
                            diagram2D[i + 2, j + 2 + emptySpaceEachSide + numStars] = ' ';
                        }
                    }
                    break;
                case EShape.Circle:
                    if (width % 2 == 0)
                    {
                        return new char[0, 0];
                    }

                    if (width != height)
                    {
                        return new char[0, 0];
                    }

                    int radius = ((int)width - 1) / 2;
                    for (int i = 0; i < height; ++i)
                    {
                        for (int j = 0; j < width; ++j)
                        {
                            int verticalDistance = Math.Abs(radius - i);
                            int horizontalDistance = Math.Abs(radius - j);
                            if (verticalDistance * verticalDistance + horizontalDistance * horizontalDistance <= radius * radius)
                            {
                                diagram2D[i + 2, j + 2] = '*';
                            } 
                            else
                            {
                                diagram2D[i + 2, j + 2] = ' ';
                            }
                        }
                    }
                    break;
            }
            return diagram2D;
        }

        public static bool IsShape(char[,] canvas, EShape shape)
        {

            uint numRows = (uint)canvas.GetLength(0);
            uint numColumns = (uint)canvas.GetLength(1);

            if (numRows < 5 || numColumns < 5)
            {
                return false;
            }

            char[,] diagram = Draw(numColumns - 4, numRows - 4, shape);

            int diagramNumRows = diagram.GetLength(0);

            if (diagramNumRows == 0)
            {
                return false;
            }

            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    if (canvas[i, j] != diagram[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}