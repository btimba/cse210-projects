using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Developer", "NVidia", 2020, 2023);
        job1.DisplayJobDetails();

        Job job2 = new Job("Data Analyst", "Google", 2018, 2020);
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }

}

