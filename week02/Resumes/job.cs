public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Company: {_company} | Job Title: {_jobTitle} | Duration: {_startYear} - {_endYear}");
        Console.WriteLine();
    }
}