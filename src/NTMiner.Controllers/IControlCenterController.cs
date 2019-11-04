﻿using NTMiner.Core;
using NTMiner.MinerServer;
using System;
using System.Collections.Generic;

namespace NTMiner.Controllers {
    public interface IControlCenterController {
        DataResponse<List<CalcConfigData>> CalcConfigs(CalcConfigsRequest request);
        ResponseBase SaveCalcConfigs(SaveCalcConfigsRequest request);
        string GetServicesVersion();
        void CloseServices();
        ResponseBase ActiveControlCenterAdmin(string password);
        ResponseBase LoginControlCenter(SignRequest request);
        QueryClientsResponse QueryClients(QueryClientsRequest request);
        GetCoinSnapshotsResponse LatestSnapshots(GetCoinSnapshotsRequest request);
        ResponseBase AddClients(AddClientRequest request);
        ResponseBase RemoveClients(MinerIdsRequest request);
        ResponseBase UpdateClient(UpdateClientRequest request);
        DataResponse<List<ClientData>> RefreshClients(MinerIdsRequest request);
        ResponseBase UpdateClients(UpdateClientsRequest request);
        DataResponse<List<MinerGroupData>> MinerGroups(SignRequest request);
        ResponseBase AddOrUpdateMinerGroup(DataRequest<MinerGroupData> request);
        ResponseBase RemoveMinerGroup(DataRequest<Guid> request);
        ResponseBase AddOrUpdateMineWork(DataRequest<MineWorkData> request);
        ResponseBase RemoveMineWork(DataRequest<Guid> request);
        ResponseBase ExportMineWork(ExportMineWorkRequest request);
        DataResponse<string> GetLocalJson(DataRequest<Guid> request);
        DataResponse<List<MineWorkData>> MineWorks(SignRequest request);
        DataResponse<List<WalletData>> Wallets(SignRequest request);
        ResponseBase AddOrUpdateWallet(DataRequest<WalletData> request);
        ResponseBase RemoveWallet(DataRequest<Guid> request);
        DataResponse<List<PoolData>> Pools(SignRequest request);
        ResponseBase AddOrUpdatePool(DataRequest<PoolData> request);
        ResponseBase RemovePool(DataRequest<Guid> request);
        DataResponse<List<ColumnsShowData>> ColumnsShows(SignRequest request);
        ResponseBase AddOrUpdateColumnsShow(DataRequest<ColumnsShowData> request);
        ResponseBase RemoveColumnsShow(DataRequest<Guid> request);
    }
}
