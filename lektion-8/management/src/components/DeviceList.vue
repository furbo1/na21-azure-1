<template>
    <div class="card shadow">
        <div class="card-body">
            <div class="d-flex justify-content-end mb-3">
                <button class="btn btn-secondary"><i class="far fa-plus me-2"></i>NEW DEVICE</button>
            </div>

            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">DeviceId</th>
                        <th scope="col">Board Type</th>
                        <th scope="col">Location</th>
                        <th scope="col">Data</th>
                        <th scope="col">Status</th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <DeviceItem v-for="device in devices" :key="device.deviceId" :item="device" />
                </tbody>
            </table>           
        </div>
    </div>
</template>

<script>
import DeviceItem from './DeviceItem.vue'

import {mapGetters, mapActions} from 'vuex'

export default {
    components: {
        DeviceItem
    },
    methods: {
        ...mapActions(['getDevices'])
    },
    created() {
        this.getDevices(),

        setInterval(() => {
            this.getDevices();
        },5000)
    },
    computed: {
        ...mapGetters(['devices'])
    }
}
</script>

<style>


</style>