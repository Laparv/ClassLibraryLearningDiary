using System;

namespace ClassLibraryLearningDiary
{
    public class Class1
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

        public bool CheckIfLate()
        {
            
        }

    }
}
