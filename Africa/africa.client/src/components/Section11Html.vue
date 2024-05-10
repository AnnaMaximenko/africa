<template>
  <section id="app" class="section-eleven center">
    <div class="subtitle__wrapper section-three__subtitle">
      <svg
        width="38"
        height="38"
        viewBox="0 0 38 38"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M0 17.8084H13.6135L1.26944 12.0663L2.27449 9.90541L13.9361 15.3306L5.15123 5.93771L6.89122 4.3094L15.4871 13.4999L10.7654 1.83543L12.974 0.9411L17.8084 12.8814V0H20.1916V12.8814L25.025 0.9411L27.2346 1.83543L22.5119 13.4999L31.1078 4.3094L32.8488 5.93771L24.0639 15.3306L35.7246 9.90541L36.7296 12.0663L24.3865 17.8084H38V20.1916H24.3865L36.7296 25.9337L35.7246 28.0946L24.0639 22.6704L32.8488 32.0632L31.1078 33.6916L22.5119 24.5001L27.2346 36.1646L25.025 37.0589L20.1916 25.1195V38H17.8084V25.1195L12.974 37.0589L10.7654 36.1646L15.4871 24.5001L6.89122 33.6916L5.15123 32.0632L13.9361 22.6704L2.27449 28.0946L1.26944 25.9337L13.6135 20.1916H0V17.8084Z"
          fill="#A86747"
        />
      </svg>
      <p class="subtitle__text">MORE INFORMATION</p>
    </div>
    <ul class="section-eleven__ul">
      <li class="section-eleven__li section-eleven__li-one">
        <div class="section-eleven__wrap">
          <p class="section-eleven__title">GENERAL</p>
          <button @click="showOne = !showOne" class="section-eleven__circle">
            <hr class="section-eleven__hr section-eleven__hr-one" />
            <hr
              v-if="!showOne"
              class="section-eleven__hr section-eleven__hr-two"
            />
          </button>
        </div>
        <p v-if="showOne" class="section-eleven__text">
          Sed tincidunt quis amet ut. Augue et pellentesque quis sit tempus
          placerat vitae. Nunc potenti donec blandit quis sit. Faucibus purus
          odio sit massa id. Dolor quis mauris nisi mauris. Cras suspendisse mi
          tempus elementum proin nibh et elit. Mollis euismod cras in diam
          pretium etiam.
        </p>
      </li>
      <li class="section-eleven__li section-eleven__li-two">
        <div class="section-eleven__wrap">
          <p class="section-eleven__title">ISA & TRAVEL</p>
          <button @click="showTwo = !showTwo" class="section-eleven__circle">
            <hr class="section-eleven__hr section-eleven__hr-one" />
            <hr
              v-if="!showTwo"
              class="section-eleven__hr section-eleven__hr-two"
            />
          </button>
        </div>

        <p v-if="showTwo" class="section-eleven__text">
          Sed tincidunt quis amet ut. Augue et pellentesque quis sit tempus
          placerat vitae. Nunc potenti donec blandit quis sit. Faucibus purus
          odio sit massa id. Dolor quis mauris nisi mauris. Cras suspendisse mi
          tempus elementum proin nibh et elit. Mollis euismod cras in diam
          pretium etiam.
        </p>
      </li>
      <li class="section-eleven__li section-eleven__li-three">
        <div class="section-eleven__wrap">
          <p class="section-eleven__title">HEALTH & VACCINATIONs</p>
          <button
            @click="showThree = !showThree"
            class="section-eleven__circle"
          >
            <hr class="section-eleven__hr section-eleven__hr-one" />
            <hr
              v-if="!showThree"
              class="section-eleven__hr section-eleven__hr-two"
            />
          </button>
        </div>
        <p v-if="showThree" class="section-eleven__text">
          Sed tincidunt quis amet ut. Augue et pellentesque quis sit tempus
          placerat vitae. Nunc potenti donec blandit quis sit. Faucibus purus
          odio sit massa id. Dolor quis mauris nisi mauris. Cras suspendisse mi
          tempus elementum proin nibh et elit. Mollis euismod cras in diam
          pretium etiam.
        </p>
      </li>
    </ul>
  </section>
</template>
<script>
export default {
  data() {
    return {
      showOne: false,
      showTwo: false,
      showThree: false,
    };
  },
};
</script>
<style lang="scss" scoped></style>
