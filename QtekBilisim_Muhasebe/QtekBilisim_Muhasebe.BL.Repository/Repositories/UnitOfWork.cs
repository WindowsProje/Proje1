using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QtekBilisim_MuhasebeContext UnitOfWorkContext;
        public UnitOfWork(QtekBilisim_MuhasebeContext _context)
        {
            if (_context == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                UnitOfWorkContext = _context;
                SirketKayitlari = new SirketKayitRepository(UnitOfWorkContext);
                HataKayitlari = new HataKayitRepository(UnitOfWorkContext);
                UlkeKayitlari = new UlkeRepository(UnitOfWorkContext);
                StackTraceFrames = new StackTraceFrameRepository(UnitOfWorkContext);
                CariHareketleri = new CariHareketRepository(UnitOfWorkContext);
                CariKayitlari = new CariKayitRepository(UnitOfWorkContext);
                DepoKayitlari = new DepoKayitRepository(UnitOfWorkContext);
                DilKayitlari = new DilRepository(UnitOfWorkContext);
                DosyaKayitlari = new DosyaRepository(UnitOfWorkContext);
                DovizBirimleri = new DovizBirimRepository(UnitOfWorkContext);
                GrupKayitlari = new GrupRepository(UnitOfWorkContext);
                IlceKayitlari = new IlceRepository(UnitOfWorkContext);
                KullaniciKayitlari = new KullaniciRepository(UnitOfWorkContext);
                SehirKayitlari = new SehirRepository(UnitOfWorkContext);
                YetkiAlanlari = new YetkiAlanRepository(UnitOfWorkContext);
                YetkiDetaylari = new YetkiDetayRepository(UnitOfWorkContext);
                Yetkiler = new YetkiRepository(UnitOfWorkContext);
                AdetBirimleri = new AdetBirimRepository(UnitOfWorkContext);
                AlacakBakiyeleri = new AlacakBakiyeRepository(UnitOfWorkContext);
                AlisFiyatlari = new AlisFiyatRepository(UnitOfWorkContext);
                BankaBilgileri = new BankaBilgiRepository(UnitOfWorkContext);
                BankaHareketleri = new BankaHareketRepository(UnitOfWorkContext);
                BankaKayitlari = new BankaKayitRepository(UnitOfWorkContext);
                BorcBakiyeleri = new BorcBakiyeRepository(UnitOfWorkContext);
                Cekler = new CekRepository(UnitOfWorkContext);
                FaturaBilgileri = new FaturaBilgiRepository(UnitOfWorkContext);
                HareketSecimleri = new HareketSecimRepository(UnitOfWorkContext);
                KasaHareketleri = new KasaHareketRepository(UnitOfWorkContext);
                KasaKayitlari = new KasaKayitRepository(UnitOfWorkContext);
                KdvOranlari = new KdvOranRepository(UnitOfWorkContext);
                KrediKartlari = new KrediKartRepository(UnitOfWorkContext);
                Poslar = new PosRepository(UnitOfWorkContext);
                SatisFiyatlari = new SatisFiyatRepository(UnitOfWorkContext);
                Senetler = new SenetRepository(UnitOfWorkContext);
                SirketTurleri = new SirketTurRepository(UnitOfWorkContext);
                StokBakiyeUyarilari = new StokBakiyeUyariRepository(UnitOfWorkContext);
                StokHareketleri = new StokHareketRepository(UnitOfWorkContext);
                StokKayitlari = new StokKayitRepository(UnitOfWorkContext);
                TedarikciBilgileri = new TedarikciBilgiRepository(UnitOfWorkContext);
            }
        }

        public IAdetBirimRepository AdetBirimleri { get; }

        public IAlacakBakiyeRepository AlacakBakiyeleri { get; }

        public IAlisFiyatRepository AlisFiyatlari { get; }

        public IBankaBilgiRepository BankaBilgileri { get; }

        public IBankaHareketRepository BankaHareketleri { get; }

        public IBankaKayitRepository BankaKayitlari { get; }

        public IBorcBakiyeRepository BorcBakiyeleri { get; }

        public ICariHareketRepository CariHareketleri { get; }

        public ICariKayitRepository CariKayitlari { get; }

        public ICekRepository Cekler { get; }

        public IDepoKayitRepository DepoKayitlari { get; }

        public IDilRepository DilKayitlari { get; }

        public IDosyaRepository DosyaKayitlari { get; }

        public IDovizBirimRepository DovizBirimleri { get; }

        public IFaturaBilgiRepository FaturaBilgileri { get; }

        public IGrupRepository GrupKayitlari { get; }

        public IHareketSecimRepository HareketSecimleri { get; }

        public IHataKayitRepository HataKayitlari { get; }

        public IIlceRepository IlceKayitlari { get; }

        public IKasaHareketRepository KasaHareketleri { get; }

        public IKasaKayitRepository KasaKayitlari { get; }

        public IKdvOranRepository KdvOranlari { get; }

        public IKrediKartRepository KrediKartlari { get; }

        public IKullaniciRepository KullaniciKayitlari { get; }

        public IPosRepository Poslar { get; }

        public IRolRepository Roller { get; }

        public ISatisFiyatRepository SatisFiyatlari { get; }

        public ISehirRepository SehirKayitlari { get; }

        public ISenetRepository Senetler { get; }

        public ISirketKayitRepository SirketKayitlari { get; }

        public ISirketTurRepository SirketTurleri { get; }

        public IStackTraceFrameRepository StackTraceFrames { get; }

        public IStokBakiyeUyariRepository StokBakiyeUyarilari { get; }

        public IStokHareketRepository StokHareketleri { get; }

        public IStokKayitRepository StokKayitlari { get; }

        public ITedarikciBilgiRepository TedarikciBilgileri { get; }

        public IUlkeRepository UlkeKayitlari { get; }

        public IYetkiAlanRepository YetkiAlanlari { get; }

        public IYetkiDetayRepository YetkiDetaylari { get; }

        public IYetkiRepository Yetkiler { get; }

        public int Complete()
        {
            return UnitOfWorkContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await UnitOfWorkContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            UnitOfWorkContext.Dispose();
        }
    }
}
