//-----------------------------------------------------------------------
// <copyright file="RecommendationType.cs" company="Beemway">
//     Copyright (c) Beemway. All rights reserved.
// </copyright>
// <license>
//     Microsoft Public License (Ms-PL http://opensource.org/licenses/ms-pl.html).
//     Contributors may add their own copyright notice above.
// </license>
//-----------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace LinkedIn.ServiceEntities
{
  /// <summary>
  /// Represents a recommendation type.
  /// </summary>
  [XmlRoot("recommendation-type")]
  public class RecommendationType
  {
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="RecommendationType"/> class.
    /// </summary>
    public RecommendationType()
    {
    }
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the code of the recommendation type.
    /// </summary>
    /// <remarks>Possible values are: business-partner, colleague, education, service-provider.</remarks>
    [XmlElement("code")]
    public string Code
    {
      get;
      set;
    }
    #endregion
  }
}
