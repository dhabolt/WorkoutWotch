using System;
using ReactiveUI;
using WorkoutWotch.Utility;
using WorkoutWotch.Models;
using Kent.Boogaart.HelperTrinity.Extensions;
using System.Reactive.Linq;
using System.Reactive.Disposables;

namespace WorkoutWotch.ViewModels
{
	public sealed class ExerciseViewModel : DisposableReactiveObject
	{
        private readonly CompositeDisposable disposables;
        private readonly Exercise model;
        private readonly ObservableAsPropertyHelper<ExecutionContext> executionContext;
        private readonly ObservableAsPropertyHelper<TimeSpan> progress;
        private readonly ObservableAsPropertyHelper<bool> isActive;

        public ExerciseViewModel(Exercise model, IObservable<ExecutionContext> executionContext)
        {
            model.AssertNotNull("model");
            executionContext.AssertNotNull("executionContext");

            this.disposables = new CompositeDisposable();
            this.model = model;

            this.executionContext = executionContext
                .ToProperty(this, x => x.ExecutionContext)
                .AddTo(this.disposables);

            this.isActive = this.WhenAnyValue(
                    x => x.ExecutionContext,
                    x => x.ExecutionContext.CurrentExercise,
                    (ec, currentExercise) => ec != null && currentExercise == this.model)
                .ToProperty(this, x => x.IsActive)
                .AddTo(this.disposables);

            this.progress = this.WhenAnyValue(x => x.ExecutionContext)
                .Select(
                    _ => this.WhenAnyValue(
                        x => x.ExecutionContext.CurrentExercise,
                        x => x.ExecutionContext.CurrentExerciseProgress,
                        (currentExercise, currentExerciseProgress) => this.ExecutionContext.CurrentExercise == this.model ? currentExerciseProgress : (TimeSpan?)null)
                    .Where(x => x.HasValue)
                    .Select(x => x.Value)
                    .StartWith(TimeSpan.Zero))
                .Switch()
                .ToProperty(this, x => x.Progress)
                .AddTo(this.disposables);
        }

        public Exercise Model
        {
            get { return this.model; }
        }

        public string Name
        {
            get { return this.model.Name; }
        }

        public TimeSpan Duration
        {
            get { return this.model.Duration; }
        }

        public TimeSpan Progress
        {
            get { return this.progress.Value; }
        }

        public bool IsActive
        {
            get { return this.isActive.Value; }
        }

        private ExecutionContext ExecutionContext
        {
            get { return this.executionContext.Value; }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                this.disposables.Dispose();
            }
        }
	}
}