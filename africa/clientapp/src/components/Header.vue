<template>
  <header>
      <div id="app" class="header__wrapper center">
          <a href="#">
              <img src="../assets/img/Logo_Frika Safaris.svg" alt="logo" />
          </a>
          <div class="header-right__menu">
              <router-link class="header__menu"
                           v-for="link in rightArr"
                           :key="link.id"
                           :to="link.url">
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
        methods: {
        },
    };
</script>

<style lang="scss" scoped></style>
