﻿var text = "'Oh, you can't help that,' said the Cat: 'we're all mad here. I'm mad. You're mad.'";
var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
var words = text.Split().Select(x => x.Trim(punctuation));