﻿// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
// 
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
// ------------------------------------------------------------------------
namespace WorkoutWotch.UnitTests.Services.Analytics.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class AnalyticsServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Analytics.IAnalyticsService>, global::WorkoutWotch.Services.Contracts.Analytics.IAnalyticsService
    {
        public AnalyticsServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public void Identify(System.String userId, global::System.Collections.Generic.IDictionary<System.String, System.String> metadata)
        {
            this.Apply(x => x.Identify(userId, metadata));
        }

        public void Track(System.String id, global::System.Collections.Generic.IDictionary<System.String, System.String> metadata)
        {
            this.Apply(x => x.Track(id, metadata));
        }

        public global::System.IDisposable TrackTime(System.String id, global::System.Collections.Generic.IDictionary<System.String, System.String> metadata)
        {
            return this.Apply(x => x.TrackTime(id, metadata));
        }

        public void RecordException(global::System.Exception exception, global::WorkoutWotch.Services.Contracts.Analytics.ExceptionLevel exceptionLevel, global::System.Collections.IDictionary metadata)
        {
            this.Apply(x => x.RecordException(exception, exceptionLevel, metadata));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.Logger.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class LoggerServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Logger.ILoggerService>, global::WorkoutWotch.Services.Contracts.Logger.ILoggerService
    {
        public LoggerServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::WorkoutWotch.Services.Contracts.Logger.LogLevel Threshold
        {
            get
            {
                return this.Apply(x => x.Threshold);
            }

            set
            {
                this.ApplyPropertySet(x => x.Threshold, value);
            }
        }

        public System.Boolean IsDebugEnabled
        {
            get
            {
                return this.Apply(x => x.IsDebugEnabled);
            }
        }

        public System.Boolean IsInfoEnabled
        {
            get
            {
                return this.Apply(x => x.IsInfoEnabled);
            }
        }

        public System.Boolean IsPerfEnabled
        {
            get
            {
                return this.Apply(x => x.IsPerfEnabled);
            }
        }

        public System.Boolean IsWarnEnabled
        {
            get
            {
                return this.Apply(x => x.IsWarnEnabled);
            }
        }

        public System.Boolean IsErrorEnabled
        {
            get
            {
                return this.Apply(x => x.IsErrorEnabled);
            }
        }

        public global::System.IObservable<global::WorkoutWotch.Services.Contracts.Logger.LogEntry> Entries
        {
            get
            {
                return this.Apply(x => x.Entries);
            }
        }

        public global::WorkoutWotch.Services.Contracts.Logger.ILogger GetLogger(global::System.Type forType)
        {
            return this.Apply(x => x.GetLogger(forType));
        }

        public global::WorkoutWotch.Services.Contracts.Logger.ILogger GetLogger(System.String name)
        {
            return this.Apply(x => x.GetLogger(name));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.Logger.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class LoggerMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Logger.ILogger>, global::WorkoutWotch.Services.Contracts.Logger.ILogger
    {
        public LoggerMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public System.String Name
        {
            get
            {
                return this.Apply(x => x.Name);
            }
        }

        public System.Boolean IsDebugEnabled
        {
            get
            {
                return this.Apply(x => x.IsDebugEnabled);
            }
        }

        public System.Boolean IsInfoEnabled
        {
            get
            {
                return this.Apply(x => x.IsInfoEnabled);
            }
        }

        public System.Boolean IsPerfEnabled
        {
            get
            {
                return this.Apply(x => x.IsPerfEnabled);
            }
        }

        public System.Boolean IsWarnEnabled
        {
            get
            {
                return this.Apply(x => x.IsWarnEnabled);
            }
        }

        public System.Boolean IsErrorEnabled
        {
            get
            {
                return this.Apply(x => x.IsErrorEnabled);
            }
        }

        public void Log(global::WorkoutWotch.Services.Contracts.Logger.LogLevel level, System.String message)
        {
            this.Apply(x => x.Log(level, message));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.State.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class StateServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.State.IStateService>, global::WorkoutWotch.Services.Contracts.State.IStateService
    {
        public StateServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.IObservable<T> Get<T>(System.String key)
        {
            return this.Apply(x => x.Get<T>(key));
        }

        public global::System.IObservable<global::System.Reactive.Unit> Set<T>(System.String key, T value)
        {
            return this.Apply(x => x.Set<T>(key, value));
        }

        public global::System.IObservable<global::System.Reactive.Unit> Remove<T>(System.String key)
        {
            return this.Apply(x => x.Remove<T>(key));
        }

        public global::System.IObservable<global::System.Reactive.Unit> Save()
        {
            return this.Apply(x => x.Save());
        }

        public global::System.IDisposable RegisterSaveCallback(global::WorkoutWotch.Services.Contracts.State.SaveCallback saveCallback)
        {
            return this.Apply(x => x.RegisterSaveCallback(saveCallback));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.Delay.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class DelayServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Delay.IDelayService>, global::WorkoutWotch.Services.Contracts.Delay.IDelayService
    {
        public DelayServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.IObservable<global::System.Reactive.Unit> Delay(global::System.TimeSpan duration)
        {
            return this.Apply(x => x.Delay(duration));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.ExerciseDocument.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class ExerciseDocumentServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.ExerciseDocument.IExerciseDocumentService>, global::WorkoutWotch.Services.Contracts.ExerciseDocument.IExerciseDocumentService
    {
        public ExerciseDocumentServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.IObservable<System.String> ExerciseDocument
        {
            get
            {
                return this.Apply(x => x.ExerciseDocument);
            }
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.Audio.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class AudioServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Audio.IAudioService>, global::WorkoutWotch.Services.Contracts.Audio.IAudioService
    {
        public AudioServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.IObservable<global::System.Reactive.Unit> Play(System.String name)
        {
            return this.Apply(x => x.Play(name));
        }
    }
}
namespace WorkoutWotch.UnitTests.Services.Speech.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class SpeechServiceMock : global::PCLMock.MockBase<global::WorkoutWotch.Services.Contracts.Speech.ISpeechService>, global::WorkoutWotch.Services.Contracts.Speech.ISpeechService
    {
        public SpeechServiceMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.IObservable<global::System.Reactive.Unit> Speak(System.String speechString)
        {
            return this.Apply(x => x.Speak(speechString));
        }
    }
}
namespace WorkoutWotch.UnitTests.Models.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class ActionMock : global::PCLMock.MockBase<global::WorkoutWotch.Models.IAction>, global::WorkoutWotch.Models.IAction
    {
        public ActionMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::System.TimeSpan Duration
        {
            get
            {
                return this.Apply(x => x.Duration);
            }
        }

        public global::System.IObservable<global::System.Reactive.Unit> Execute(global::WorkoutWotch.Models.ExecutionContext context)
        {
            return this.Apply(x => x.Execute(context));
        }
    }
}
namespace WorkoutWotch.UnitTests.Models.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class EventMock : global::PCLMock.MockBase<global::WorkoutWotch.Models.IEvent>, global::WorkoutWotch.Models.IEvent
    {
        public EventMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public global::WorkoutWotch.Models.ExecutionContext ExecutionContext
        {
            get
            {
                return this.Apply(x => x.ExecutionContext);
            }
        }
    }
}
namespace WorkoutWotch.UnitTests.Models.Mocks
{
    [System.CodeDom.Compiler.GeneratedCode("PCLMock", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class EventMatcherMock : global::PCLMock.MockBase<global::WorkoutWotch.Models.IEventMatcher>, global::WorkoutWotch.Models.IEventMatcher
    {
        public EventMatcherMock(global::PCLMock.MockBehavior behavior = global::PCLMock.MockBehavior.Strict): base (behavior)
        {
            if ((behavior) == (global::PCLMock.MockBehavior.Loose))
            {
                ConfigureLooseBehavior();
            }
        }

        partial void ConfigureLooseBehavior();
        public System.Boolean Matches(global::WorkoutWotch.Models.IEvent @event)
        {
            return this.Apply(x => x.Matches(@event));
        }
    }
}

