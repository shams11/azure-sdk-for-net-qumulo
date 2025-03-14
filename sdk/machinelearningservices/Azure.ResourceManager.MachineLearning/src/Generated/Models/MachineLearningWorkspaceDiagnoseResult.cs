// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningWorkspaceDiagnoseResult.
    /// Serialized Name: DiagnoseResponseResult
    /// </summary>
    public partial class MachineLearningWorkspaceDiagnoseResult
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceDiagnoseResult. </summary>
        internal MachineLearningWorkspaceDiagnoseResult()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceDiagnoseResult. </summary>
        /// <param name="value"> Serialized Name: DiagnoseResponseResult.value. </param>
        internal MachineLearningWorkspaceDiagnoseResult(MachineLearningDiagnoseResultValue value)
        {
            Value = value;
        }

        /// <summary> Serialized Name: DiagnoseResponseResult.value. </summary>
        public MachineLearningDiagnoseResultValue Value { get; }
    }
}
