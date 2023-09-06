﻿namespace SpeechToText.Services;

public interface IFileHandler
{
    Task Download(string fileId, CancellationToken ct);
    string Process(string param);
}