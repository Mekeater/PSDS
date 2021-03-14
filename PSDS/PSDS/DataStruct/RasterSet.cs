using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobeCode.DataStruct
{
    public struct RasterSet
    {
        public string Name; //栅格数据集名称
        public string Format;
        public IPoint Origin; 
        public int columnCount;
        public int RowCount;
        public double cellSizeX;
        public double cellSizeY;
        public int numBands;
        public rstPixelType PixelType;
        public ISpatialReference SpatialReference;

        //默认的参考
        private ISpatialReference spatialReference()
        {
            ISpatialReferenceFactory pSpatialReferenceEnvironemnt = new SpatialReferenceEnvironment();
            ISpatialReferenceFactory2 pSpatialReferenceFactory2 = pSpatialReferenceEnvironemnt as ISpatialReferenceFactory2;
            ISpatialReference pSpatialReference = pSpatialReferenceFactory2.CreateSpatialReference(4326);
            //esriSRProjCS4Type 
            //esriSRGeoCS3Type
            //esriSRDatum3Type
            return pSpatialReference;
        }


        public void rasterSet(string Name, string Format, IPoint Origin, int columnCount, int RowCount, double cellSizeX, double cellSizeY, int numBands, rstPixelType PixelType, ISpatialReference SpatialReference = null)
        {
            this.Name = Name;
            this.Format = Format;
            this.Origin = Origin;
            this.columnCount = columnCount;
            this.RowCount = RowCount;
            this.cellSizeX = cellSizeX;
            this.cellSizeY = cellSizeY;
            this.numBands = numBands;
            this.PixelType = PixelType;
            if (SpatialReference != null)
                this.SpatialReference = SpatialReference;
            else
                this.SpatialReference = spatialReference();

            ISpatialReferenceInfo ptest = this.SpatialReference as ISpatialReferenceInfo;
            long t = ptest.FactoryCode;
        }
    }
}
