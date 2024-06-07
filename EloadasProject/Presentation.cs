namespace PresentationProject
{
    public class Presentation
    {
        public bool[,] reservations;

        public Presentation(int NumOfLines, int NumOfAvailableSeats)
        {
            this.reservations = new bool[NumOfLines, NumOfAvailableSeats];

            if (NumOfLines < 0 ||  NumOfAvailableSeats < 0 )
            {
                throw new ArgumentException(nameof(NumOfLines), nameof(NumOfAvailableSeats));
            }
        }

        public bool Reservation()
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

        public int getNumOfFreeSeats()
        {
            int freeSeats = 0;
            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (reservations[i, j] == false)
                    {
                        freeSeats ++;
                        
                    }

                }
            }
            return freeSeats;
            
        }

        public bool getFull()
        {
            for (int i = 0; i < reservations.GetLength(0); i++)
            {
                for (int j = 0; j < reservations.GetLength(1); j++)
                {
                    if (!reservations[i, j])
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public bool AlreadyReservedSeat(int NumOfLines, int NumOfAvailableSeats)
        {
            if (NumOfLines < 1 || NumOfAvailableSeats < 1 || NumOfLines > reservations.GetLength(0) || NumOfLines > reservations.GetLength(1))
                throw new ArgumentException("Invalid line or seat!");

            return reservations[NumOfLines - 1, NumOfAvailableSeats - 1];
        }

        
    }
}
