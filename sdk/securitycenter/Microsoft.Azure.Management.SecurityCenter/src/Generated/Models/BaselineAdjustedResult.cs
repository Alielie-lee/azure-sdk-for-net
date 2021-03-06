// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The rule result adjusted with baseline.
    /// </summary>
    public partial class BaselineAdjustedResult
    {
        /// <summary>
        /// Initializes a new instance of the BaselineAdjustedResult class.
        /// </summary>
        public BaselineAdjustedResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaselineAdjustedResult class.
        /// </summary>
        /// <param name="status">Possible values include: 'NonFinding',
        /// 'Finding', 'InternalError'</param>
        /// <param name="resultsNotInBaseline">Results the are not in
        /// baseline.</param>
        /// <param name="resultsOnlyInBaseline">Results the are in
        /// baseline.</param>
        public BaselineAdjustedResult(Baseline baseline = default(Baseline), string status = default(string), IList<IList<string>> resultsNotInBaseline = default(IList<IList<string>>), IList<IList<string>> resultsOnlyInBaseline = default(IList<IList<string>>))
        {
            Baseline = baseline;
            Status = status;
            ResultsNotInBaseline = resultsNotInBaseline;
            ResultsOnlyInBaseline = resultsOnlyInBaseline;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseline")]
        public Baseline Baseline { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NonFinding', 'Finding',
        /// 'InternalError'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets results the are not in baseline.
        /// </summary>
        [JsonProperty(PropertyName = "resultsNotInBaseline")]
        public IList<IList<string>> ResultsNotInBaseline { get; set; }

        /// <summary>
        /// Gets or sets results the are in baseline.
        /// </summary>
        [JsonProperty(PropertyName = "resultsOnlyInBaseline")]
        public IList<IList<string>> ResultsOnlyInBaseline { get; set; }

    }
}
