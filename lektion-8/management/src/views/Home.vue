<template>
  <div id="home">
    <DeviceList />
  </div>
</template>

<script>
import DeviceList from '../components/DeviceList.vue'

export default {
  name: 'Home',
  components: {
    DeviceList
  }
}
</script>
