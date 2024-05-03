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
          <button @click="show = !show" key="menu" class="header__button">
            PLAN A TRIP
          </button>

          <form action="https://localhost:7272/api/Applications" method="POST" v-if="show" id="myDropdown" class="form">
            <h3 class="form__title">Application form</h3>
            <input
              placeholder="Name"
              required
              class="form__input"
              type="text"
              name="name"
              id=""
            />
            <input
              placeholder="Phone"
              required
              class="form__input"
              type="tel"
              name="phone"
              id=""
            />
            <input
              placeholder="E-mail"
              required
              class="form__input"
              type="email"
              name=""
              id=""
            />
            <button class="form__button" onclick="Do">Send</button>
          </form>
        </div>
      </div>
    </div>
  </header>
</template>

<script>
export default {
  data() {
    return {
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
            DoPost() {

            }
        },
};
</script>

<style lang="scss" scoped></style>
