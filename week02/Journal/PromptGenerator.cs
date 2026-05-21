using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Internal list of prompts (Contains 7 distinct prompts to exceed the minimum requirement of 5)
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was a specific problem you solved or a neat thing you built today?",
        "What is something you want to make sure you remember about today five years from now?"
    };

    // Picks and returns a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}