namespace State
{
    public class Editor
    {
        private IWritingState _writingState;

        public Editor()
        {
            _writingState = new DefaultWrite();
        }

        public void SetState(IWritingState writingState)
        {
            _writingState = writingState;
        }

        public void Write(string words)
        {
            _writingState.Write(words);
        }
    }
}