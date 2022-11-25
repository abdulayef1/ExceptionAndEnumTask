namespace Task2.Services
{
    public class StudentGroupCheckService
    {
        public bool CheckGroupNo(string groupName)
        {
            if (groupName.Length==5)
            {
                if (FindDigit(groupName)==3)
                {
                    if(FindUpper(groupName)==2)
                        return true;
                }
                return false;
            }

            return false;
        }

        public int FindDigit(string str)
        {
            int countDigit=0;
            foreach (var letter in str)
            {
                if (Char.IsDigit(letter))
                    countDigit++;
            }
            return countDigit;
        }
        public int FindUpper(string str)
        {
            int countUpper=0;
            foreach (var letter in str)
            {
                if (Char.IsUpper(letter))
                    countUpper++;
            }
            return countUpper;
        }
    }
}
