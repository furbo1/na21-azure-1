<template>
  <div id="app" class="container mt-5">
    <router-view/>
  </div>
</template>

<style>
  * {
    font-family: 'Poppins', sans-serif;
  }

  body {
    color: #194039;
    background: #eceef9;
  }

  .btn:focus {
      box-shadow: 0 0 0 0 rgb(0,0,0,0);
  }

  .btn:hover {
      background: #6f5a99;
  }

  .table .btn:hover {
      background: transparent;
      color: #6f5a99;
  }
</style>
