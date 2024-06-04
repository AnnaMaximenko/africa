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
export default {
  data() {
    return {
      name: "",
      phone: "",
      email: "",
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
    // send() {
    //   axios.post(
    //     "http://localhost/priangan/api/user/login",
    //     {
    //       name: this.state.name,
    //       phone: this.state.phone,
    //       email: this.state.email,
    //     },
    //     {
    //       headers: {
    //         "Content-type": "application/json; charset=UTF-8",
    //       },
    //     }
    //   );
    // },
  },
};
</script>

<style lang="scss" scoped></style>
