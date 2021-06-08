<template>
<tr>
    <td>{{item.deviceId}}</td>
    <td>
        <div>{{item.properties.reported.sensorType}}</div>
        <div class="text-muted small">{{item.properties.reported.boardType}}</div>
    </td>
    <td>
        <div>{{item.properties.reported.location}}</div>
        <div class="text-muted small">{{item.properties.reported.gps.latitude}}, {{item.properties.reported.gps.longitude}}</div>
    </td>
    <td>
        <div class="d-flex align-items-center justify-content-start">
            <div class="me-3">
                <div class="d-flex justify-content-start align-items-center">
                    <div class="me-3" style="width: 10px;"><i class="fas fa-thermometer-half ms-1"></i></div>
                    <div>{{item.properties.reported.data.temperature}} °C</div>
                </div>
                <div class="d-flex justify-content-start align-items-center">
                    <div class="me-3" style="width: 10px;"><i class="fas fa-dewpoint"></i></div>
                    <div>{{item.properties.reported.data.humidity}} %</div>
                </div>
            </div>
            <div v-if="item.properties.reported.data.temperatureAlert == true" class="text-warning"><i class="fas fa-exclamation-triangle"></i></div>
            <div v-else class="text-white"><i class="fas fa-exclamation-triangle"></i></div>
        </div>
    </td>
    <td>
        <div v-if="item.connectionState == 'Connected'" class="status-online">{{item.connectionState}}</div>
        <div v-else class="status-offline">{{item.connectionState}}</div>
    </td>
    <td>
        <div class="d-flex align-items-center justify-content-end">
            
            <button @click="toggleSendData(item)" class="btn">
                <i :class="item.properties.reported.sending ? 'fas fa-pause': 'fas fa-play'"></i>
            </button>    
            <button class="btn"><i class="fas fa-comment-alt-lines"></i></button>
            <button class="btn"><i class="fas fa-trash"></i></button>
        </div>
    </td>
</tr>
</template>

<script>
import {mapActions} from 'vuex'


export default {
    props: ['item'],
    methods: {
        ...mapActions(['toggleSendData'])
    }
}
</script>

<style>
    .status-online,
    .status-offline {
        width: 140px;
        padding: 0.3rem 0;
        text-align:center;
        font-weight: 500;
        border-radius: 7px;
    }

    .status-online {
        background: #cdf5de;
        color: #4f8b79;
    }
    .status-offline {
        background: #ffe1e8;
        color: #8a505b;
    }

    .table td {
        vertical-align: middle;
    }
</style>