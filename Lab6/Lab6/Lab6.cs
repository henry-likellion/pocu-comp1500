namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] arr)
        {
            int numRows = arr.GetLength(0);
            int numColumns = arr.GetLength(1);
            int[,] rotatedArr = new int[numColumns, numRows];

            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    rotatedArr[j, numRows - i - 1] = arr[i, j];
                }
            }

            return rotatedArr;
        }

        public static void TransformArray(int[,] arr, EMode mode)
        {
            int numRows = arr.GetLength(0);
            int numColumns = arr.GetLength(1);

            switch (mode)
            {
                case EMode.HorizontalMirror:
                    for (int i = 0; i < numRows; ++i)
                    {
                        int[] rowData = new int[numColumns];

                        for (int j = 0; j < numColumns; ++j)
                        {
                            rowData[j] = arr[i, j];
                        }

                        for (int j = 0; j < numColumns; ++j)
                        {
                            arr[i, j] = rowData[numColumns - 1 - j];
                        }
                    }
                    break;
                case EMode.VerticalMirror:
                    for (int i = 0; i < numColumns; ++i)
                    {
                        int[] columnData = new int[numRows];

                        for (int j = 0; j < numRows; ++j)
                        {
                            columnData[j] = arr[j, i];
                        }

                        for (int j = 0; j < numRows; ++j)
                        {
                            arr[j, i] = columnData[numRows - 1 - j];
                        }
                    }
                    break;
                case EMode.DiagonalShift:
                    for (int i = 0; i < numRows; ++i)
                    {
                        int[] rowData = new int[numColumns];

                        for (int j = 0; j < numColumns; ++j)
                        {
                            rowData[j] = arr[i, j];
                        }

                        for (int j = 0; j < numColumns; ++j)
                        {
                            if (j > 0)
                            {
                                arr[i, j] = rowData[j - 1];
                            }
                            else
                            {
                                arr[i, j] = rowData[numColumns - 1];
                            }
                        }
                    }

                    for (int i = 0; i < numColumns; ++i)
                    {
                        int[] columnData = new int[numRows];

                        for (int j = 0; j < numRows; ++j)
                        {
                            columnData[j] = arr[j, i];
                        }

                        for (int j = 0; j < numRows; ++j)
                        {
                            if (j > 0)
                            {
                                arr[j, i] = columnData[j - 1];
                            }
                            else
                            {
                                arr[j, i] = columnData[numRows - 1];
                            }
                        }
                    }
                    break;
            }
        }
    }
}