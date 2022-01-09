namespace CourseApp
{
    public interface IVoiceAssist
    {
        string NameAssistant { get; }

        string CallAnAssistant();

        string RecallAnAssistant();
    }
}
