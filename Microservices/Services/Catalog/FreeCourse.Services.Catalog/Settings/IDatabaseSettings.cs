namespace FreeCourse.Services.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        /*
           "DatabaseSettings": {
                "CourseCollectionName": "Courses",
                "CategoryCollectionName": "Categories",
                "ConnectionString": "mongodb://localhost:27017",
                "DatabaseName": "CatalogDb"
         */

        public string CourseCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}