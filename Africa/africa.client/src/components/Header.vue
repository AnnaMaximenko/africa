<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <header>
    <div id="app" class="header__wrapper center">
      <a href="#">
        <img src="../assets/img/Logo_Frika Safaris.svg" alt="logo"
      /></a>
      <div class="header-right__menu">
        <router-link
          class="header__menu"
          v-for="link in rightArr"
          :key="link.id"
          :to="link.url"
        >
          {{ link.name }}
        </router-link>
        <div class="header__dropdown">
          <a id="link" href="#myDropdown" key="menu" class="header__button">
            PLAN A TRIP
          </a>
        </div>
      </div>
    </div>
  </header>
</template>

<script>
import axios from "axios";
export default {
  data() {
    return {
      applicationData: {
        name: "",
        phone: "",
        email: "",
      },
      rightArr: [
        { id: 0, name: "Destinations", url: "/" },
        { id: 1, name: "About Us", url: "/" },
        { id: 2, name: "Experience", url: "/" },
        { id: 3, name: "Blog", url: "/" },
      ],
      show: false,
    };
  },
  methods: {
    onSendApplication() {
      console.log(this.applicationData);
      return axios.post("https://localhost:7272/api/Applications", {
        name: this.applicationData.name,
        email: this.applicationData.email,
        phoneNumber: this.applicationData.phone,
      });
    },
  },
};
</script>

<style lang="scss" scoped></style>
