using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        // Add at least 5 distinct prompts to make the journal feel more natural
        _prompts.Add("Who was the most interesting person you spoke with today?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How did you feel the Lord's presence today?");
        _prompts.Add("What was the strongest emotion you experienced today?");
        _prompts.Add("If you could relive one moment from today, what would it be?");
        _prompts.Add("What did you learn today that you didn't know before?");
        _prompts.Add("What made you smile today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}