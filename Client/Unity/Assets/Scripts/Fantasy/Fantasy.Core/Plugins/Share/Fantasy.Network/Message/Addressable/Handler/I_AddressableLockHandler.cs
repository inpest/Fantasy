#if FANTASY_SERVER
namespace Fantasy.Core.Network;

public sealed class I_AddressableLockHandler : RouteRPC<Scene, I_AddressableLock_Request, I_AddressableLock_Response>
{
    protected override async FTask Run(Scene scene, I_AddressableLock_Request request, I_AddressableLock_Response response, Action reply)
    {
        await scene.GetComponent<AddressableManageComponent>().Lock(request.AddressableId);
    }
}
#endif
