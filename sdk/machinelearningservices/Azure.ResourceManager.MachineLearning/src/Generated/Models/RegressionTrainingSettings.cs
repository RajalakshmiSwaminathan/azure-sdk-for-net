// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Regression Training related configuration. </summary>
    public partial class RegressionTrainingSettings : TrainingSettings
    {
        /// <summary> Initializes a new instance of RegressionTrainingSettings. </summary>
        public RegressionTrainingSettings()
        {
            AllowedTrainingAlgorithms = new ChangeTrackingList<RegressionModel>();
            BlockedTrainingAlgorithms = new ChangeTrackingList<RegressionModel>();
        }

        /// <summary> Initializes a new instance of RegressionTrainingSettings. </summary>
        /// <param name="enableDnnTraining"> Enable recommendation of DNN models. </param>
        /// <param name="enableModelExplainability"> Flag to turn on explainability on best model. </param>
        /// <param name="enableOnnxCompatibleModels"> Flag for enabling onnx compatible models. </param>
        /// <param name="enableStackEnsemble"> Enable stack ensemble run. </param>
        /// <param name="enableVoteEnsemble"> Enable voting ensemble run. </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </param>
        /// <param name="stackEnsembleSettings"> Stack ensemble settings for stack ensemble run. </param>
        /// <param name="allowedTrainingAlgorithms"> Allowed models for regression task. </param>
        /// <param name="blockedTrainingAlgorithms"> Blocked models for regression task. </param>
        internal RegressionTrainingSettings(bool? enableDnnTraining, bool? enableModelExplainability, bool? enableOnnxCompatibleModels, bool? enableStackEnsemble, bool? enableVoteEnsemble, TimeSpan? ensembleModelDownloadTimeout, StackEnsembleSettings stackEnsembleSettings, IList<RegressionModel> allowedTrainingAlgorithms, IList<RegressionModel> blockedTrainingAlgorithms) : base(enableDnnTraining, enableModelExplainability, enableOnnxCompatibleModels, enableStackEnsemble, enableVoteEnsemble, ensembleModelDownloadTimeout, stackEnsembleSettings)
        {
            AllowedTrainingAlgorithms = allowedTrainingAlgorithms;
            BlockedTrainingAlgorithms = blockedTrainingAlgorithms;
        }

        /// <summary> Allowed models for regression task. </summary>
        public IList<RegressionModel> AllowedTrainingAlgorithms { get; set; }
        /// <summary> Blocked models for regression task. </summary>
        public IList<RegressionModel> BlockedTrainingAlgorithms { get; set; }
    }
}
