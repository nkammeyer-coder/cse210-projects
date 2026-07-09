using System;
using System.Collections.Generic;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>()
  {
      "Who was the most interesting person I interacted with today? ",
      "What was the best part of my day? ",
      "How did I see the hand of the Lord in my life today? ",
      "What was the strongest emotion I felt today? ",
      "If I had one thing I could do over today, what would it be? ",
      "How would you describe your day?",
      "Did you think to pray today? ",
      "What was a shining moment of your day? ",
      "Who did you bless today? ",
      "What blessings did you recognize today? "

  };
  public string GetRandomPrompt()
    {
        Random randomPromptGenerator = new Random();
        int index = randomPromptGenerator.Next(_prompts.Count);

        return _prompts[index];
    }
    
}