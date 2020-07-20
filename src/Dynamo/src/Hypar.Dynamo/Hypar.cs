using System;
using System.Collections.Generic;
using System.Linq;

using ADSK = Autodesk.Revit.DB;
using DynamoRevit = Revit.Elements;
using RevitServices.Persistence;
using Autodesk.DesignScript.Runtime;

using Elements.Serialization.glTF;
using Hypar.Revit;

namespace Hypar.Dynamo
{
    public static class SpaceBoundary
    {
        /// <summary>
        /// Convert a Revit Area into a SpaceBoundary element. This currently only
        /// stores the perimeter polygon, and no geometric representation, so you will 
        /// not see it in 3D views in Hypar.
        /// </summary>
        /// <param name="revitArea">The area that is meant to be converted to a Hypar SpaceBoundary.</param>
        /// <param name="areaPlan">Provide the view where the area is visible to speed up computation.</param>
        /// <returns name="SpaceBoundary">The Hypar space boundary elements.</returns>
        public static Elements.SpaceBoundary[] FromArea(DynamoRevit.Element revitArea, [DefaultArgument("HyparDynamo.Hypar.SpaceBoundary.GetNull()")] DynamoRevit.Views.AreaPlanView areaPlan = null)
        {
            var areaElement = (ADSK.Area)revitArea.InternalElement;
            var doc = DocumentManager.Instance.CurrentDBDocument;

            return Create.SpaceBoundaryFromRevitArea(areaElement, doc, areaPlan == null ? null : (Autodesk.Revit.DB.View)areaPlan?.InternalElement);
        }

        [IsVisibleInDynamoLibrary(false)]
        public static object GetNull()
        {
            // This technique copied from this example.  Allowing null as a default case appears to be a special case
            // https://github.com/ksobon/archilab/blob/master/archilabSharedProject/Revit/Selection/Selection.cs
            return null;
        }
    }

    public static class ModelPoints
    {
        /// <summary>
        /// Convert a list of points from Dynamo into a ModelPoints element with optional name.
        /// </summary>
        /// <param name="points">The points that will be stored.</param>
        /// <param name="name">An optional name to be assigned to the model points.</param>
        /// <returns name="ModelPoints">The ModelPoint objects for Hypar.</returns>
        public static Elements.ModelPoints FromPoints(List<Autodesk.DesignScript.Geometry.Point> points, string name = "")
        {
            return Create.ModelPointsFromPoints(points.Select(p => new ADSK.XYZ(p.X, p.Y, p.Z)), name);
        }
    }

    public static class Wall
    {
        /// <summary>
        /// Convert a Revit wall to Elements.WallByProfile(s) for use in Hypar models.
        /// Sometimes a single wall in Revit needs to be converted to multiple Hypar walls.
        /// </summary>
        /// <param name="revitWall">The walls to be exported.</param>
        /// <returns name="WallByProfiles">The Hypar walls.</returns>
        public static Elements.WallByProfile[] FromRevitWall(DynamoRevit.Wall revitWall)
        {
            var revitWallElement = (Autodesk.Revit.DB.Wall)revitWall.InternalElement;

            // wrapped exception catching to deliver more meaningful message in Dynamo
            try
            {
                return Create.WallsFromRevitWall(revitWallElement, DocumentManager.Instance.CurrentDBDocument);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public static class Floor
    {
        /// <summary>
        /// Convert a Revit floor to Elements.Floor(s) for use in Hypar models.
        /// Sometimes a single floor in Revit needs to be converted to multiple Hypar floors.
        /// </summary>
        /// <param name="revitFloor">The floor to be exported.</param>
        /// <returns name="Floors">The Hypar floors.</returns>
        public static Elements.Floor[] FromRevitFloor(DynamoRevit.Floor revitFloor)
        {
            var revitFloorElement = (Autodesk.Revit.DB.Floor)revitFloor.InternalElement;

            // wrapped exception catching to deliver more meaningful message in Dynamo
            try
            {
                return Create.FloorsFromRevitFloor(DocumentManager.Instance.CurrentDBDocument, revitFloorElement);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public static class Column
    {
        /// <summary>
        /// Convert a Revit column to an Elements.Column for use in Hypar models.
        /// </summary>
        /// <param name="revitColumn">The column to be exported.</param>
        /// <returns name="Column">The Hypar column element.</returns>
        public static Elements.Column FromRevitColumn(DynamoRevit.Element revitColumn)
        {
            var revitColumnElement = (Autodesk.Revit.DB.FamilyInstance)revitColumn.InternalElement;
            try
            {
                return Create.ColumnFromRevitColumn(revitColumnElement, DocumentManager.Instance.CurrentDBDocument);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public static class Model
    {
        /// <summary>
        /// Write a Hypar model to JSON.
        /// </summary>
        /// <param name="filePath">The path to write the JSON file.</param>
        /// <param name="model">The Hypar Model to write.</param>
        public static void WriteJson(string filePath, Elements.Model model)
        {
            try
            {
                var json = model.ToJson();
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Write a Hypar model to glTF. 
        /// </summary>
        /// <param name="filePath">The path to write the JSON file.</param>
        /// <param name="model">The Hypar Model to write.</param>
        public static void WriteGlb(string filePath, Elements.Model model)
        {
            try
            {
                model.ToGlTF(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Create a Hypar Model from a list of Elements.
        /// </summary>
        /// <param name="elements">The list of Elements that should be added to the model.</param>
        /// <returns name="Model">The Hypar Model to write.</returns>
        public static Elements.Model FromElements(IList<object> elements)
        {
            var model = new Elements.Model();
            var elems = elements.Cast<Elements.Element>().Where(e => e != null);

            model.AddElements(elems);

            return model;
        }
    }
}