﻿namespace Persimmon.VisualStudio.TestRunner.Internals
{
    public interface ISinkTrampoline
    {
        void Begin(string message);

        void Message(bool isError, string message);

        void Progress(dynamic[] args);

        void Finished(string message);
    }
}
