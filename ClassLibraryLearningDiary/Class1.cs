using System;

namespace ClassLibraryLearningDiary
{
    public class MethodLibrary
    {
        public bool CheckFuture(DateTime given)
        {
            if (given < DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckIfLate(DateTime given, double days)
        {           

            if (given.AddDays(days) < DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Lassen kommentti
    }
}
