﻿using AndroidX.Fragment.App;
using AuthenticatorPro.Activities;
using AuthenticatorPro.Fragments;
using Fragment = AndroidX.Fragment.App.Fragment;
using FragmentManager = AndroidX.Fragment.App.FragmentManager;

namespace AuthenticatorPro.Intro
{
    internal class IntroPagerAdapter : FragmentStatePagerAdapter
    {
        public IntroPagerAdapter(FragmentManager manager) : base(manager) { }

        public override int Count => IntroActivity.PageCount;

        public override Fragment GetItem(int position)
        {
            return new IntroPageFragment(position);
        }
    }
}