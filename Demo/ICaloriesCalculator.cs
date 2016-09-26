using System.ServiceModel;
using System.ServiceModel.Web;

namespace Demo
{
    [ServiceContract]
    public interface ICaloriesCalculator
    {
        [OperationContract]
        [WebGet]
        ActivityDetailes[] GetAllActivities();

        [OperationContract]
        [WebGet]
        int GetBurnedCalories(string id, int trainingMinutes);
    }

}
