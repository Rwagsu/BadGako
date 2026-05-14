using System;

namespace BadGako.Models.Classes;

public sealed record NavigateMessage(Type PageType);

public sealed record GoBackMessage();