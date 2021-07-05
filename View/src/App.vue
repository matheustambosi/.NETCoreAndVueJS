<template>
  <div id="app">
    <div class="container">
      <button @click="getPessoas">Listar</button>
    </div>
  </div>
</template>

<script>
const axios = require("axios");

export default {
  methods: {
    getPessoas: function() {
      axios.get("https://localhost:44358/pessoa").then(function(response) {
        response.data.map(function(pessoa) {
          console.log(pessoa);
        });
      });
    },
  },
};
</script>

<style>
.container {
  width: 98vw;
  height: 98vh;
  display: flex;
  justify-content: center;
  align-items: center;
}

button {
  background: #016abc;
  color: #fff;
  border: 1px solid #eee;
  border-radius: 20px;
  box-shadow: 5px 5px 5px #eee;
  text-shadow: none;
  width: 150px;
  height: 70px;
  font-size: 40px;
}
</style>
