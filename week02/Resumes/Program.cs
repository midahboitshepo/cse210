using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "System Analyst";
        job1._company = "Local Governement";
        job1._startYear = 2009;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "DCDMC";
        job2._startYear = 2011;
        job2._endYear = 2013;

        Resume myResume = new Resume();
        myResume._name = "Midah Boitshepo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}