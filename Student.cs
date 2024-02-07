namespace Student
{
    public class MyStudent
    {
        int id;
        string name;
        int studyYear;
        int[] grades;
        int numberOfCourses;
        public MyStudent(int id, string name, int studyYear, int[] grades, int numberOfCourses)
        {
            this.id = id;
            this.name = name;
            this.studyYear = studyYear;
            
            this.numberOfCourses = numberOfCourses;
            this.grades = new int[numberOfCourses];
            for( int i=0; i < numberOfCourses; i++)
            {
                this.grades[i] = grades[i];
            }
        }

        public double GetAverage()
        {
            int sum = 0;// mistake on purpose
            foreach(int grade in this.grades)
            {
                sum += grade;
            }
            return (double)sum/ this.numberOfCourses;
        }

        public string GetClassification()
        {
            if (GetAverage() > 90)
                return "A";
            if (GetAverage() > 80)
                return "B";
            if (GetAverage() > 70)
                return "C";
            if (GetAverage() > 55)
                return "D";
            return "F";
        }
        
    }
}