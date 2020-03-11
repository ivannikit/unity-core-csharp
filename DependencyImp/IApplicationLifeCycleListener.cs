using System;

namespace TeamZero.Core
{
    public interface IApplicationLifeCycleListener : 
        IApplicationLaunchListener, 
        IApplicationEarlyResumeListener,
        IApplicationResumeListener, 
        IApplicationPauseListener, 
        IApplicationLatePauseListener, 
        IApplicationLoseFocusListener, 
        IApplicationQuitListener
    {
    }

    public interface IApplicationLaunchListener
    {
        event Action ApplicationLaunch;
    }
    
    public interface IApplicationEarlyResumeListener
    {
        event Action ApplicationEarlyResume;
    }
    
    public interface IApplicationResumeListener
    {
        event Action ApplicationResume;
    }
    
    public interface IApplicationPauseListener
    {
        event Action ApplicationPause;
    }
    
    public interface IApplicationLatePauseListener
    {
        event Action ApplicationLatePause;
    }
    
    public interface IApplicationLoseFocusListener
    {
        event Action ApplicationLoseFocus;
    }
    
    public interface IApplicationQuitListener
    {
        event Action ApplicationQuit;
    }
}
