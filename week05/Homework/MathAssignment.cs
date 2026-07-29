using System;

class MathAssignment : Assignment
{

        private string _textbookSection;
        private string _problems;

        // Four parameters set forth. Two are being passed to the parent constructor "Assignment".
        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        // Variables set to MathAssignment
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problem {_problems}";
    }
    
}