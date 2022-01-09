namespace RemoteManager.ModuleSystem; 

public class MalformedModuleException : Exception {
    private readonly string _message;
    private readonly Exception? _internalError;

    public MalformedModuleException(string message) {
        _message = message;
    }

    public MalformedModuleException(string message, Exception internalError) {
        _message = message;
        _internalError = internalError;
    }

    public override string ToString() {
        if(_internalError is not null) {
            return _message + "\n\tCaused by: " + _internalError;
        }

        return _message;
    }
}