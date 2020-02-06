using System;
using System.Threading.Tasks;

namespace Clase1.Interfaces
{
    public interface ITextToSpeech
    {

        Task Speak(string text);

    }
}
