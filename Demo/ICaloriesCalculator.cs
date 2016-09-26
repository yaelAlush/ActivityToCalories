using System.ServiceModel;
using System.ServiceModel.Web;

namespace Demo
{
    [ServiceContract]
    public interface ICaloriesCalculator
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        ActivityDetailes[] GetAllActivities();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        int GetBurnedCalories(string id, int trainingMinutes);
    }
}
