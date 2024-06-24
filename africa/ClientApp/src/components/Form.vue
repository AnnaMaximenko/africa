<!-- eslint-disable vue/multi-word-component-names -->
<template>
    <form @submit.prevent="onSendApplication"
          id="myDropdown"
          class="form center">
        <h3 class="form__title">Application form</h3>
        <div class="form__input_box">
            <label class="form__label">Name</label>
            <input class="form__input"
                   v-bind:class="{ 'form__input_hasError': v$.name.$invalid }"
                   v-model="v$.name.$model"
                   type="text"
                   name="name"
                   id="" />
            <p class="form__error_message"
                  v-for="err in v$.name.$errors"
                  :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <div class="form__input_box">
            <label class="form__label">Phone</label>
            <input v-model="v$.phone.$model"
                   v-bind:class="{ 'form__input_hasError': v$.phone.$invalid }"
                   class="form__input"
                   type="tel"
                   name="phone"
                   id="" />
            <p class="form__error_message"
                  v-for="err in v$.phone.$errors"
                  :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <div class="form__input_box">
            <label class="form__label">Email</label>
            <input v-model.trim="v$.email.$model"
                   v-bind:class="{ 'form__input_hasError': v$.email.$invalid }"
                   class="form__input"
                   type="email"
                   name=""
                   id="" />
            <p class="form__error_message"
                  v-for="err in v$.email.$errors"
                  :key="err.$uid">
                *{{ err.$message }}
            </p>
        </div>
        <button type="submit" class="form__button">Send</button>
    </form>
</template>

<script>
    import axios from 'axios';
    import { reactive, computed } from 'vue';
    import { email, required, helpers } from '@vuelidate/validators';
    import { useVuelidate } from '@vuelidate/core';

    export default {
        setup() {
            const application = reactive({
                name: '',
                phone: '',
                email: '',
            });

            const number = helpers.regex(
                "serial",
                /^[0-9]{3}-[0-9]{3}-[0-9]{4}$/
            );

            const rules = computed(() => ({
                name: { required },
                email: { required, email },
                phone: { required, number }
            }));

            const v$ = useVuelidate(rules, application);

            return {
                application,
                v$,
            };
        },

        methods: {
            onSendApplication() {
                this.v$.$touch(); 
                try {
                    return axios.post('api/Applications', {
                        name: this.application.name,
                        email: this.application.email,
                        phone: this.application.phone,
                    });
                } catch (error) {
                    console.error(error);
                }
            }
        }
    };
</script>
