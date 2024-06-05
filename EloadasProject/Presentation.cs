namespace PresentationProject
{
    public class Presentation
    {
        public bool[,] reservations;

        public Presentation(int NumOfLines, int NumOfAvailableSpaces)
        {
            this.reservations = new bool[NumOfLines, NumOfAvailableSpaces];

            if (NumOfLines < 0 ||  NumOfAvailableSpaces < 0 )
            {
                throw new ArgumentException(nameof(NumOfLines), nameof(NumOfAvailableSpaces));
            }
        }

        public bool Engage()
        {
            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (reservations[i, j] == false)
                    {
                        reservations[i, j] = true;
                        return true;
                    }
                    
                }
            }
            return false;
            
        }

        public int getFreeSpaces()
        {
            int freeSpaces = 0;
            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (reservations[i, j] == false)
                    {
                        freeSpaces ++;
                        
                    }

                }
            }
            return freeSpaces;
            
        }

        public bool getFull(int freeSpaces)
        {
            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (freeSpaces == 0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public bool AlreadyTaken(int NumOfLines, int NumOfAvailableSpaces)
        {
            if (NumOfLines < 1 || NumOfAvailableSpaces < 1 )
            {
                throw new ArgumentException(nameof(NumOfLines), nameof(NumOfAvailableSpaces));
            }

            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (reservations[i,j] == false)
                    {
                        return true;
                    }

                }
            }
            return false;



        }

        
    }
}
